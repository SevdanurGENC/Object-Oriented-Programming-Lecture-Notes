package Abstract;

public class Dikdortgen extends Sekil {

	Dikdortgen(double a, double b) {
		super(a, b);
		// TODO Auto-generated constructor stub
	}

	@Override
	double alan() {
		// TODO Auto-generated method stub
		System.out.println("Dikdortgenin Alani : ");
		return kenar1 * kenar2;
	}
	
	@Override
	double hacim(double x, double y) {
		return x+y;
	}
	
}
