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
        public async Task<IEnumerable<AssertRegisterDTO>> GetAssertRegisters(int userId)
        {
            return await //assertContext.AssertRegisters.Where(T => T.UserId == userId && T.IsActive == true).ToListAsync();
            (from AS in assertContext.AssertRegisters
             where AS.UserId == userId && AS.IsActive == true
             select new AssertRegisterDTO
             {
                 AssertRegisterId = AS.AssertRegisterId,
                 IdentificationNumber = AS.IdentificationNumber,      
                 CoordinatesX = AS.CoordinatesX,
                 CoordinatesY = AS.CoordinatesY,
                 DateOfPurchase = AS.DateOfPurchase,
                 LocationOfOrigin=AS.LocationOfOrigin,
                 AssertName= (from M in assertContext.Asserts where M.AssertId == AS.AssertId select M.AssertName).FirstOrDefault(),
                 SubAssertName = (from M in assertContext.SubAsserts where M.SubAssertId == AS.SubAssertId select M.SubAssertName).FirstOrDefault(),

             }).ToListAsync();
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
                result.DateOfLastInspection = assertRegister.DateOfLastInspection;
                result.DateOfInspection = assertRegister.DateOfInspection;
                result.AssetStatusId = assertRegister.AssetStatusId;
                result.CoordinatesX = assertRegister.CoordinatesX;
                result.CoordinatesY = assertRegister.CoordinatesY;
                result.MunicipalId = assertRegister.MunicipalId;
                result.IdentificationNumber = assertRegister.IdentificationNumber;
                result.PriorityId = assertRegister.PriorityId;
                result.UtilizationRateId = assertRegister.UtilizationRateId;                
                result.StrategyLastMaintenanceId = assertRegister.StrategyLastMaintenanceId;
                result.MaintenanceContractForAsset = assertRegister.MaintenanceContractForAsset;
                result.FrequentProblems = assertRegister.FrequentProblems;              
                result.LocationOfOrigin = assertRegister.LocationOfOrigin;
                result.DepartmentName = assertRegister.DepartmentName;
                result.GuaranteeExpiryDate = assertRegister.GuaranteeExpiryDate;
                result.Evidence = assertRegister.Evidence;
                result.AccidentDescription = assertRegister.AccidentDescription;
                result.AssertId = assertRegister.AssertId;
                result.SubAssertId = assertRegister.SubAssertId;
                result.UploadEvidenseId = assertRegister.UploadEvidenseId;
                result.UploadEvidenseId1 = assertRegister.UploadEvidenseId1;
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
