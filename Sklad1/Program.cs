namespace Sklad
{
class Program

    {

    public static void Main(string [] args){
        //test aplikace

            
            Sklad<int> skladCisel = new Sklad<int>();

            skladCisel.AddItem(1);
            skladCisel.AddItem(6);
            skladCisel.AddItem(112);
            skladCisel.AddItem(5);

            Console.WriteLine("Sklad cisel obsahuje: " + string.Join(", ", skladCisel.GetItems()));

            skladCisel.Removeitem(98);
              Console.WriteLine("Sklad cisel obsahuje: " + string.Join(", ", skladCisel.GetItems()));

              skladCisel.Removeitem(14);
              Console.WriteLine("Sklad cisel obsahuje: " + string.Join(", ", skladCisel.GetItems()));



              Sklad<String>skladovoce = new Sklad<String>();
              
            skladovoce.AddItem("banany");
            skladovoce.AddItem("Jablko");
            skladovoce.AddItem("Pomeranc");
            skladovoce.AddItem("Meloun");

            Console.WriteLine("Sklad cisel obsahuje: " + string.Join(", ", skladovoce.GetItems()));

            skladCisel.Removeitem(98);
              Console.WriteLine("Sklad cisel obsahuje: " + string.Join(", ", skladovoce.GetItems()));

              skladCisel.Removeitem(14);
              Console.WriteLine("Sklad cisel obsahuje: " + string.Join(", ", skladovoce.GetItems()));



         }
    }

}
