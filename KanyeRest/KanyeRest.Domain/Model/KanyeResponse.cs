namespace KanyeRest.Domain.Model
{
    public class KanyeResponse
    {
        public string Name { get; set; } = "Kanye Omari West";
        public DateTime BirthDate { get; set; } = new DateTime(1997, 6, 8);
        public int Age => DateTime.Now.Year - BirthDate.Year 
                        -(DateTime.Now < BirthDate.AddYears(DateTime.Now.Year - BirthDate.Year) ? 1 : 0);
        public static string Biography => "Ye, born Kanye Omari West, is an American rapper, singer and record producer. One of the most prominent figures in hip-hop, he is known for his varying musical style and polarizing cultural and political commentary.";
    }
}
