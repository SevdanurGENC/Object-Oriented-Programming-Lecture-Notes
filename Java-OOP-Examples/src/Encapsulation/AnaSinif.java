package Encapsulation;

public class AnaSinif {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Ucgen cevre = new Ucgen();
		
		cevre.setKenar1(10);
		cevre.setKenar2(36);
		cevre.setKenar3(200);
		
		System.out.println("Ucgenin 1.kenari : " + cevre.getKenar1());
		System.out.println("Ucgenin 2.kenari : " + cevre.getKenar2());
		System.out.println("Ucgenin 3.kenari : " + cevre.getKenar3());
		
		System.out.println("Ucgenin Cevresi : " + cevre.UcgenCevreHesapla());	
		
		
		
	}

}
