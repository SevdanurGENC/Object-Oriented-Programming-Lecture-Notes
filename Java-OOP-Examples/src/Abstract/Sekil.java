package Abstract;

public abstract class Sekil {
	
	double kenar1, kenar2;
	
	Sekil(double a, double b){
		kenar1 = a;
		kenar2 = b;
	}
	
	abstract double alan();
	
	double hacim(double a, double b) {
		return a*b; 
	}
}
