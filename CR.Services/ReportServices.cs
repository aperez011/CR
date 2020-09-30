using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR.Data;
using CR.Entities.DTO;
using CR.Utilities;
using CR.Utilities.Enums;
using CR.Utilities.Infraestructure;

namespace CR.Services
{
    public class ReportServices : IReportServices
    {
        private dbModelContext _context;

        public OperationResult<ReportDTO> GetReportBy(int userId, DateTime date)
        {
            try
            {
                ReportDTO result = new ReportDTO();
                List<DetailDTO> getOpenDetail = new List<DetailDTO>();
                List<DetailDTO> getCloseDetail = new List<DetailDTO>();

                using (_context = new dbModelContext())
                {

                    var registers = _context.CashRegisters.Where(r => r.CashierId == userId
                                                                  && r.DateRegister == date).ToList();

                    var expenses = _context.CashExpenses.Where(ex => ex.RegisterDate == date && ex.UserId == userId).ToList();
                    var openCashier = registers.FirstOrDefault(c => c.RegisterType == Guid.Parse(CashRegisterTypes.Apertura.GetDescription()));
                    var closeCashier = registers.FirstOrDefault(c => c.RegisterType == Guid.Parse(CashRegisterTypes.Cierre.GetDescription()));

                    if (openCashier != null)
                    {
                        getOpenDetail = _context.Coins
                                                   .Join(_context.CashRegisterDetails,
                                                           co => co.Id,
                                                           cr => cr.CoinId,
                                                           (co, cr) => new { Coin = co, Detail = cr })
                                                   .Where(c => c.Detail.CashRegisterId == openCashier.Id).Select(c => new DetailDTO
                                                   {
                                                       CoinName = c.Coin.Name,
                                                       RegisterType = openCashier.RegisterType,
                                                       RefNum = c.Detail.RefNumber,
                                                       CoinType = c.Coin.Type,
                                                       CoinAmount = c.Detail.CoinAmount,
                                                       TotalAmount = c.Detail.TotalAmount,
                                                       RegisterDate = c.Detail.LogDate
                                                   }).ToList();
                    }

                    if (closeCashier != null)
                    {
                        getCloseDetail = _context.Coins
                                                .Join(_context.CashRegisterDetails,
                                                        co => co.Id,
                                                        cr => cr.CoinId,
                                                        (co, cr) => new { Coin = co, Detail = cr })
                                                .Where(c => c.Detail.CashRegisterId == closeCashier.Id).Select(c => new DetailDTO
                                                {
                                                    CoinName = c.Coin.Name,
                                                    RegisterType = closeCashier.RegisterType,
                                                    RefNum = c.Detail.RefNumber,
                                                    CoinType = c.Coin.Type,
                                                    CoinAmount = c.Detail.CoinAmount,
                                                    TotalAmount = c.Detail.TotalAmount,
                                                    RegisterDate = c.Detail.LogDate
                                                }).ToList();


                    }

                    var totalOpenAmount = openCashier?.TotalAmount ?? 0;
                    var totalCloseAmount = closeCashier?.TotalAmount ?? 0;
                    var totalExpenses = expenses.Sum(c => c.BillAmount);

                    var cashBalance = ((totalCloseAmount - totalOpenAmount) - totalExpenses);

                    //Header
                    result.Header = new CashierReportDTO
                    {
                        UserName = StaticProperties.User.UserName.ToUpper(),
                        Date = date.ToString("dd/MM/yyyy").ToUpper(),
                        OpenAmount = totalOpenAmount.ToString("C"),
                        CloseAmount = totalCloseAmount.ToString("C"),
                        ExpensesAmount = totalExpenses.ToString("C"),
                        CashBalance = cashBalance.ToString("C")
                    };

                    //Resumen
                    result.DetailResume = new BalanceDetails
                    {
                        OpenCash = getOpenDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Efectivo.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        OpenCards = getOpenDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Tarjeta.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        OpenCredit = getOpenDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Credito.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        OpenDeposit = getOpenDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Deposito.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        OpenTransfer = getOpenDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Transferencia.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),

                        CloseCash = getCloseDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Efectivo.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        CloseCards = getCloseDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Tarjeta.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        CloseCredit = getCloseDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Credito.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        CloseDeposit = getCloseDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Deposito.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        CloseTransfer = getCloseDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Transferencia.GetDescription())).Sum(c => c.TotalAmount).ToString("C")
                    };

                    result.DetailResume.Details.AddRange(getOpenDetail);
                    result.DetailResume.Details.AddRange(getCloseDetail);


                }

                return OperationResult<ReportDTO>.SetSucces(result);
            }
            catch (Exception ex)
            {
                return OperationResult<ReportDTO>.SetFail(ex.Message);
            }
        }

        public OperationResult<ReportDTO> GetReportByShift(int shiftId)
        {

            try
            {
                ReportDTO result = new ReportDTO();
                List<DetailDTO> getOpenDetail = new List<DetailDTO>();
                List<DetailDTO> getCloseDetail = new List<DetailDTO>();

                using (_context = new dbModelContext())
                {

                    var registers = _context.CashRegisters.Where(r => r.ShiftId == shiftId).ToList();

                    var openCashier = registers.FirstOrDefault(c => c.RegisterType == Guid.Parse(CashRegisterTypes.Apertura.GetDescription()));
                    var closeCashier = registers.FirstOrDefault(c => c.RegisterType == Guid.Parse(CashRegisterTypes.Cierre.GetDescription()));
                    var expenses = _context.CashExpenses.Where(ex => ex.RegisterDate == openCashier.DateRegister && ex.UserId == openCashier.CashierId).ToList();

                    if (openCashier != null)
                    {
                        getOpenDetail = _context.Coins
                                                   .Join(_context.CashRegisterDetails,
                                                           co => co.Id,
                                                           cr => cr.CoinId,
                                                           (co, cr) => new { Coin = co, Detail = cr })
                                                   .Where(c => c.Detail.CashRegisterId == openCashier.Id).Select(c => new DetailDTO
                                                   {
                                                       CoinName = c.Coin.Name,
                                                       RegisterType = openCashier.RegisterType,
                                                       RefNum = c.Detail.RefNumber,
                                                       CoinType = c.Coin.Type,
                                                       CoinAmount = c.Detail.CoinAmount,
                                                       TotalAmount = c.Detail.TotalAmount,
                                                       RegisterDate = c.Detail.LogDate
                                                   }).ToList();
                    }

                    if (closeCashier != null)
                    {
                        getCloseDetail = _context.Coins
                                                .Join(_context.CashRegisterDetails,
                                                        co => co.Id,
                                                        cr => cr.CoinId,
                                                        (co, cr) => new { Coin = co, Detail = cr })
                                                .Where(c => c.Detail.CashRegisterId == closeCashier.Id).Select(c => new DetailDTO
                                                {
                                                    CoinName = c.Coin.Name,
                                                    RegisterType = closeCashier.RegisterType,
                                                    RefNum = c.Detail.RefNumber,
                                                    CoinType = c.Coin.Type,
                                                    CoinAmount = c.Detail.CoinAmount,
                                                    TotalAmount = c.Detail.TotalAmount,
                                                    RegisterDate = c.Detail.LogDate
                                                }).ToList();


                    }

                    var totalOpenAmount = openCashier?.TotalAmount ?? 0;
                    var totalCloseAmount = closeCashier?.TotalAmount ?? 0;
                    var totalExpenses = expenses.Sum(c => c.BillAmount);

                    var cashBalance = ((totalCloseAmount - totalOpenAmount) - totalExpenses);

                    //Header
                    result.Header = new CashierReportDTO
                    {
                        UserName = StaticProperties.User.UserName.ToUpper(),
                        Date = openCashier.DateRegister.ToString("dd/MM/yyyy").ToUpper(),
                        OpenAmount = totalOpenAmount.ToString("C"),
                        CloseAmount = totalCloseAmount.ToString("C"),
                        ExpensesAmount = totalExpenses.ToString("C"),
                        CashBalance = cashBalance.ToString("C")
                    };

                    //Resumen
                    result.DetailResume = new BalanceDetails
                    {
                        OpenCash = getOpenDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Efectivo.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        OpenCards = getOpenDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Tarjeta.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        OpenCredit = getOpenDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Credito.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        OpenDeposit = getOpenDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Deposito.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        OpenTransfer = getOpenDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Transferencia.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),

                        CloseCash = getCloseDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Efectivo.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        CloseCards = getCloseDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Tarjeta.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        CloseCredit = getCloseDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Credito.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        CloseDeposit = getCloseDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Deposito.GetDescription())).Sum(c => c.TotalAmount).ToString("C"),
                        CloseTransfer = getCloseDetail.Where(c => c.CoinType == Guid.Parse(CoinsType.Transferencia.GetDescription())).Sum(c => c.TotalAmount).ToString("C")
                    };

                    result.DetailResume.Details.AddRange(getOpenDetail);
                    result.DetailResume.Details.AddRange(getCloseDetail);


                }

                return OperationResult<ReportDTO>.SetSucces(result);
            }
            catch (Exception ex)
            {
                return OperationResult<ReportDTO>.SetFail(ex.Message);
            }
        }

        public OperationResult<IEnumerable<ReportDTO>> GetReportByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public OperationResult<IEnumerable<FilterInformation>> GetFilterInfoByDate(DateTime startDate, DateTime endDate)
        {
            startDate = DateTime.Parse("7/1/2020");

            var info = new List<FilterInformation>();

            using (_context = new dbModelContext())
            {
                var result = _context.CashRegisters
                    .Select(cr => new CashTransformToFilter
                    {
                        Shift = cr.ShiftId,
                        Cashier = cr.CashierId,
                        DateRegister = cr.DateRegister
                    }).ToList();

                var cashiers = result.Select(c => c.Cashier).Distinct().ToList();

                var shifts = result.Select(sh => new
                                        {
                                            sh.Cashier,
                                            ShiftId = sh.Shift,
                                            ShiftCode = sh.Shift.ToString()
                                        }).Distinct().ToList();

                cashiers.ForEach(c =>
                {
                    info.Add(new FilterInformation
                    {
                        User = _context.User.Select(us => new UserDTO { Id = us.Id, UserName = us.UserName, Rol = string.Empty }).FirstOrDefault(u => u.Id == c),
                        Shifts = shifts.Where(s => s.Cashier == c).Select(sh=> new ShiftsInf { ShiftId = sh.ShiftId, ShiftCode = sh.ShiftCode }).ToList()
                    });
                });
            }

            return OperationResult<IEnumerable<FilterInformation>>.SetSucces(info);
        }
    }
}
