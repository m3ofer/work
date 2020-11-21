package com.esisa.java;

import java.awt.Color;

public class Pixel extends Object {
	private Color color;//abstract windowing toolkit
	//super a 2 usage possible usage 1er dans un instructeur permet invoquer l'instructeur de la class mere
	//2emme pour acceder a quell mombre accesible de la class mere
	//"this" does the same thing as super but can only access only the current runing class
	//
	public Pixel() {
		
	}
	@Override
	public void print() {
		System.out.println("Pixel:"+ ",");
	}
}
