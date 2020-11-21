package com.esisa.java;

public class Primitive {
	public Primitive() {
		exp01();
		exp02();
		exp03();
		exp04();
	}
	
	void exp01() {
		
	}
	
	void exp02() {
		//type wrappers:
		//byte, shot, Integer, Long
		//float, Double, character, boolean
		
		Integer x=20;//Autoboxing
		System.out.println(x);
		
		int a = x; //Unboxing since jdk 1.5
	}
	
	void exp03() {
		String s = "20";
		double x = Double.parseDouble(s);
		System.out.println(x);
		
		s="30a";
		int a=0;
		// a = Integer.parseInt(s);
		try {
			a = Integer.parseInt(s);
		} catch (Exception e) {
			// TODO: handle exception
			System.out.println("Erreur : "+ e.getMessage());
		}
		System.out.println(a);
		
	}
	
	void exp04() {
		
	}

	public static void main(String[] args) {
		new Primitive();
	}
}
