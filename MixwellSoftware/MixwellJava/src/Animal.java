import java.util.*;

import org.apache.commons.lang3.text.WordUtils;
import org.apache.commons.lang3.exception.ExceptionUtils;



public class Animal{


    public static final double FAVNUMBER = 1.618;
    private String name;
    private int weight;
    private boolean hasOwner = false;
    private byte age;
    private long uniqueID;
    private double speed;
    private float height;
    private char favoriteChar;

    protected static int numberOfAnimals = 0;

    static Scanner userinput = new Scanner(System.in);

    public Animal(){
        numberOfAnimals++;
        int sumOfNumbers = 5+1;
        System.out.println("5 + 1 = " + sumOfNumbers);
        int diffOfNumbers = 5-1;
        System.out.println("5 - 1 = " + diffOfNumbers);
        int multOfNumbers = 5*1;
        System.out.println("5 * 1 = " + multOfNumbers);
        int divOfNumbers = 5/1;
        System.out.println("5 / 1 = " + divOfNumbers);
        int modOfNumbers = 5%1;
        System.out.println("5 % 1 = " + modOfNumbers);

        //System.out.print("Enter the name: \n");

 
    }
 
    public void setName(String name){
        this.name = name;
    }

    public String getName(){
        return name;
    }
    
    public void setWeight(int weight){
        this.weight= weight;
    }

    public int getWeight(){
        return weight;
    } 

    public void setHasOwner(boolean hasOwner){
        this.hasOwner = hasOwner;
    }

    public boolean getHasOwner(){
        return hasOwner;
    }
    
    public void setAge(byte age){
        this.age= age;
    }

    public byte getAge(){
        return age;
    } 

    public void setUniqueID(long uniqueID){
        this.uniqueID= uniqueID;
    }

    public void setUniqueID(){
        long minNumber = 1;
        long maxNumber = 1000000;
        this.uniqueID= minNumber + (long)(Math.random()*((maxNumber-minNumber)+1));
        String stringNumber = Long.toString(maxNumber);
    }

    public long getUniqueID(){
        return uniqueID;
    } 

    public void setSpeed(double speed){
        this.speed = speed;
    }

    public double getSpeed(){
        return speed;
    }
    
    public void setHeight(float height){
        this.height= height;
    }

    public float getHeight(){
        return height;
    } 

    public void setFavoriteChar(char favoriteChar){
        this.favoriteChar= favoriteChar;
    }

    public char getFavoriteChar(){
        return favoriteChar;
    } 


    public String makeSound(){
        return "Grrrr";
    }

    public static void speakAnimal(Animal randAnimal){

        System.out.println("Animal says " + randAnimal.makeSound());
    }

    public static void main(String[] args) {

//        System.out.println("Hello");
        
        Animal theAnimal = new Animal();


        Animal fido = new Dog();
        Animal fluffy = new Cat();

        System.out.println(fido.makeSound()); 
        System.out.println(fluffy.makeSound()); 

    
        String text = WordUtils.capitalize("Hello"); // WordUtils.capitalize("Hello");
        String text1 = "Hello";
        System.out.println(text); 

    }
     
}