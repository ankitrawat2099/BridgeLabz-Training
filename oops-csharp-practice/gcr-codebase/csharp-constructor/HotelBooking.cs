using System;
class HotelBooking
{
    public string GuestName;
    public string RoomType;
    public int Nights;

    public HotelBooking() {
		GuestName = "ankit";
        RoomType = "single";
        Nights = 1;

	}

    public HotelBooking(string guest, string room, int nights)
    {
        GuestName = guest;
        RoomType = room;
        Nights = nights;
    }

    public HotelBooking(HotelBooking hb)
    {
        GuestName = hb.GuestName;
        RoomType = hb.RoomType;
        Nights = hb.Nights;
    }
	static void Main(){
	HotelBooking h1=new HotelBooking();
	Console.WriteLine(h1.GuestName+" "+h1.RoomType+" "+h1.Nights);
	HotelBooking h2=new HotelBooking("abhishek","dual",2);
		Console.WriteLine(h2.GuestName+" "+h2.RoomType+" "+h2.Nights);
	HotelBooking h3=new HotelBooking(h1);
		Console.WriteLine(h3.GuestName+" "+h3.RoomType+" "+h3.Nights);
	}
}
