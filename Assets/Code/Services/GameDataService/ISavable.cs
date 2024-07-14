namespace Code.Services.GameDataService
{
    public interface ISavable
    {
        void Load(IData data);
        IData Save();
    }
}