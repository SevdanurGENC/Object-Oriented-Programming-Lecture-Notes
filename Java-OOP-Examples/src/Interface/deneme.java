package Interface;

public class deneme implements arayuz01, arayuz02 {

	public static final String isim = "Kutu2";
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		deneme degisken = new deneme();
		degisken.hacim(3, 5, 7);
		degisken.topla(12, 15);
		degisken.ekranaYaz(degisken.isim);
		
		System.out.println("Fiyat Degeri : " + degisken.fiyat);
		System.out.println("Sayac Degeri : " + degisken.sayac);
		System.out.println("Isim Degeri : " + degisken.isim);
		
	}
	
	//public static final double fiyat = 16.90;

	@Override
	public void ekranaYaz(String isim) {
		// TODO Auto-generated method stub
		System.out.println("Islem ismi : " + isim);
	}

	@Override
	public void topla(int x, int y) {
		// TODO Auto-generated method stub
		System.out.println("Sayi1 + Sayi2 = " + (x+y));
	}

	@Override
	public void hacim(int x, int y, int z) {
		// TODO Auto-generated method stub
		System.out.println("Hacim Sonuc : " + (x*y*z));
	}

}
