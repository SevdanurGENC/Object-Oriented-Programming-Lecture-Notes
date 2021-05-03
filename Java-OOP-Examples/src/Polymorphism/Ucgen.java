package Polymorphism;

public class Ucgen extends Sekil {
	public Ucgen(double k1, double k2) {
		super(k1,k2);
	}
	
	double alanHesapla() {
		System.out.println("Ucgenin Alani : ");
		return kenar1 * kenar2 / 2;
	}	
}
