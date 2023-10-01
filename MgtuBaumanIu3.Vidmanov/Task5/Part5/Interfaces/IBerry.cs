namespace MgtuBaumanIu3.Vidmanov.Task5.Part5.Interfaces;

public interface IBerry
{
    public void SetColor(BerryColor color);
    public BerryColor GetColor();
    public void SetHarvestDate(DateTime date);
    public DateTime GetHarvestDate();
}