package Polymorphism;

public class Dikdortgen extends Sekil {
	public Dikdortgen(double k1, double k2) {
		super(k1,k2);		
	}
	
	double alanHesapla() {
		System.out.println("Dikdortgenin Alani : ");
		return kenar1 * kenar2;
	}	
}
