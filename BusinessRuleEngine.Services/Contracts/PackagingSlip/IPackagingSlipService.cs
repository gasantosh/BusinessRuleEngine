using BusinessRuleEngine.Services.Bos.Departments;

namespace BusinessRuleEngine.Services.Contracts.PackagingSlip
{
    public interface IPackagingSlipService
    {
        PackagingSlipGenerationResponse GenerateNewSlip();

        PackagingSlipGenerationResponse GenerateDuplicateSlip(DepartmentBo department);
    }
}
