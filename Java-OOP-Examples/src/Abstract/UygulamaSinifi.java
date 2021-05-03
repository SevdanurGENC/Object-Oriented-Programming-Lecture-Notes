package Abstract;

public class UygulamaSinifi {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Dikdortgen d = new Dikdortgen(7, 77);
		Sekil ref;
		
		ref = d;
		
		System.out.println(ref.alan());
		System.out.println(ref.hacim(7, 77));	
		
		Ucgen u = new Ucgen(70,17);
		
		ref = u;
		
		System.out.println(ref.alan());
		System.out.println(ref.hacim(7, 77));	
	}

}
