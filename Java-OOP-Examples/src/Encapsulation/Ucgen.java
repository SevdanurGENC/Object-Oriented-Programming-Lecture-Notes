package Encapsulation;

public class Ucgen {

	public double Kenar1, Kenar2, Kenar3;
	
	public double getKenar1() {
		return Kenar1;
	}
	
	public void setKenar1(double kenar1) {
		this.Kenar1 = kenar1;
	}
	
	public double getKenar2() {
		return Kenar2;
	}
	
	public void setKenar2(double kenar2) {
		this.Kenar2 = kenar2;
	}
	
	public double getKenar3() {
		return Kenar3;
	}
	
	public void setKenar3(double kenar3) {
		this.Kenar3 = kenar3;
	}
	
	public double UcgenCevreHesapla() {
		return Kenar1 + Kenar2 + Kenar3;
	}
	
}
