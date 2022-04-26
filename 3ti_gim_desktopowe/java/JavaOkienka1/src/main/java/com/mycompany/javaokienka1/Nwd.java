/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.javaokienka1;

/**
 *
 * @author prof
 */
public class Nwd {
   public static int NwdRec(int a, int b){
       if(b==0) return a;
       return NwdRec(b, a%b);
   }
   public static int NwdIter(int a ,int b){
       int temp = a;
       while(b!=0){
           temp = a;
           a = b;
           b = temp % b;
       }
       return a;
   }
}
