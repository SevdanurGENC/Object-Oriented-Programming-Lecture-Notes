package Inheritance;

public class Kutu_AnaSinif {
	
	double en, boy, yukseklik;
	
	Kutu_AnaSinif(){
		en = -1;
		boy = -1;
		yukseklik = -1;
	}
	
	Kutu_AnaSinif(double e, double b, double y){
		en = e;
		boy = b;
		yukseklik = y;
	}
	
	Kutu_AnaSinif(double uzunluk){
		en = boy = yukseklik = uzunluk;
	}
	
	Kutu_AnaSinif(Kutu_AnaSinif obje){
		en = obje.en;
		boy = obje.boy;
		yukseklik = obje.yukseklik;		
	}
	
	double Hacim() {
		return en*boy*yukseklik;
	}
}
