namespace Core.Entities
{
    public class YazilimGorevi : Gorev
    {
        public override decimal HakedisHesapla()
        {
            return HourlyRate * WorkedHours; 
        }
    }
}