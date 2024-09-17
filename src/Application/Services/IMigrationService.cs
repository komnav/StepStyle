namespace Application.Services
{
    public interface IMigrationService
    {
        void Migrate();

        void CreateDefaultData();
    }
}
