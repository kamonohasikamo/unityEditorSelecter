using System.Collections.ObjectModel;

public class PrefList
{
    public ObservableCollection<string> Data { get; }
    public PrefList()
    {
        Data = new ObservableCollection<string>();
        Data.Add("北海道");
        Data.Add("青森県");
        Data.Add("岩手県");
        Data.Add("秋田県");
    }
}