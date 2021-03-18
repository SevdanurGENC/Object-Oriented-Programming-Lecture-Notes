package Inheritance;

public class KalitimOrnegi {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Kutu_AnaSinif kAnaNesne = new Kutu_AnaSinif(20, 25, 10.70);
		System.out.println(kAnaNesne.Hacim());
		System.out.println("*******************");		
		Kutu_AltSinif kAltNesne = new Kutu_AltSinif(4, 5, 6, 0.123);
		System.out.println(kAltNesne.Hacim());
		System.out.println(kAltNesne.boy);
		
	} 
}
