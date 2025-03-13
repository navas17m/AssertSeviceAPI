using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class AssertRegisterRepository:IAssertRegisterRepository
    {
        private readonly AssertDBContext assertContext;
        public AssertRegisterRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<AssertRegister>> GetAssertRegisters(int userId)
        {
            return await assertContext.AssertRegisters.Where(T => T.UserId == userId && T.IsActive == true).ToListAsync();
            //    (from AS in assertContext.AssertRegisters                          
            //              where AS.MunicipalId== MunicipalId && AS.IsActive==true
            //              select new AssertRegisterDTO { 
            //    AssertRegisterId=AS.AssertRegisterId,
            //    IdentificationNumber=AS.IdentificationNumber,
            //    MunicipalId=AS.MunicipalId,                             
            //    LocationOfOrigin=AS.LocationOfOrigin,
            //    CoordinatesX=AS.CoordinatesX,
            //    CoordinatesY=AS.CoordinatesY,
            //    DateOfPurchase=AS.DateOfPurchase

            //}).ToListAsync();
            //assertContext.AssertRegisters.ToListAsync();
        }
        public async Task<AssertRegister> GetAssertRegister(int assertRegisterId)
        {
            return await assertContext.AssertRegisters.FirstOrDefaultAsync(T=>T.AssertRegisterId== assertRegisterId && T.IsActive==true);
        }
        public async Task<AssertRegister> AddAssertRegister(AssertRegister assertRegister)
        {
            var result = await assertContext.AssertRegisters.AddAsync(assertRegister);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<AssertRegister> UpdateAssertRegister(AssertRegister assertRegister)
        {
            var result = await assertContext.AssertRegisters.FirstOrDefaultAsync(T=>T.AssertRegisterId== assertRegister.AssertRegisterId);
            if (result != null)
            {
                result.GoogleMapsLink = assertRegister.GoogleMapsLink;
                result.DateOfPurchase = assertRegister.DateOfPurchase;
                result.HistoricalCostsOfMaintenance = assertRegister.HistoricalCostsOfMaintenance;
                result.AccidentLog = assertRegister.AccidentLog;               
                result.DateOfPurchase = assertRegister.DateOfPurchase;
                result.AssetStatusId = assertRegister.AssetStatusId;
                result.CoordinatesX = assertRegister.CoordinatesX;
                result.CoordinatesY = assertRegister.CoordinatesY;
                result.MunicipalId = assertRegister.MunicipalId;
                result.IdentificationNumber = assertRegister.IdentificationNumber;
                result.PriorityId = assertRegister.PriorityId;
                result.UtilizationRateId = assertRegister.UtilizationRateId;
                result.DateOfLastInspection = assertRegister.DateOfLastInspection;
                result.StrategyLastMaintenanceId = assertRegister.StrategyLastMaintenanceId;
                result.MaintenanceContractForAsset = assertRegister.MaintenanceContractForAsset;
                result.FrequentProblems = assertRegister.FrequentProblems;
                result.DateOfLastInspection = assertRegister.DateOfLastInspection;
                result.LocationOfOrigin = assertRegister.LocationOfOrigin;
                result.DepartmentName = assertRegister.DepartmentName;
                result.GuaranteeExpiryDate = assertRegister.GuaranteeExpiryDate;
                result.Evidence = assertRegister.Evidence;
                result.AccidentDescription = assertRegister.AccidentDescription;
                await assertContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public void DeleteAssertRegister(int assertRegisterId)
        {
            var result = assertContext.AssertRegisters.FirstOrDefault(T => T.AssertRegisterId == assertRegisterId);
            if (result != null)
            {
                assertContext.AssertRegisters.Remove(result);
                assertContext.SaveChanges();
            }            
        }
        public async Task<IEnumerable<Assert>> GetAsserts()
        {
            return await assertContext.Asserts.ToListAsync();
        }
        public async Task<IEnumerable<SubAssert>> GetSubAsserts(int assertId)
        {
            return await assertContext.SubAsserts.Where(T=>T.AssertId==assertId).ToListAsync();
        }
        public async Task<IEnumerable<LastMaintenanceStrategy>> GetLastMaintenanceStrategy()
        {
            return await assertContext.LastMaintenanceStrategies.ToListAsync();
        }
        public async Task<IEnumerable<AssetStatus>> GetAssetStatus()
        {
            return await assertContext.AssetStatus.ToListAsync();
        }
        public async Task<IEnumerable<UtilizationRates>> GetUtilizationRates()
        {
            return await assertContext.UtilizationRates.ToListAsync();
        }
        public async Task<IEnumerable<Priority>> GetLastPriority()
        {
            return await assertContext.Priorities.ToListAsync();
        }
    }
}
