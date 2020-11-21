package com.esisa.java;
impo
public class Examples {
	public Examples() {
		exp01();
		//contructeur
	}
	
	void exp01() {
		Point p1=new Point(20,34);
		p1.print();
	}
	void exp02() {
		Pixel p1 = new Pixel();
		p1.setX(34);	
	}
	
	public static void main(String[] args) {
		new Examples();
	}
}
