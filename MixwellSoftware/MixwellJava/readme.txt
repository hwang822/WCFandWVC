https://www.youtube.com/watch?v=0A8K6Nlv0BE

download and install vscode.

vscode is open source tool between edit and IDE (language service)

connect vscode to github.
first download and install Git-2.22.0-64-bit.exe from https://git-scm.com
after install reopen vscode, the "Source Control" button actived.
run gitbush to add your github username and eamil.

at workarea to run git init to create repository
C:\Workarea>git init
Reinitialized existing Git repository in C:/Workarea/.git/
git remote add origin https://github.com/hwang822/rect-skeleton.git



make a java project folder
make a source golder to store source code files *.java
make a bin folder to complier java execte files.
make a lib folder to store third part libs.

create java main/base clase

evertime save the code, the code will be automatically compiler. it will show any errors.
create task to run complier, run test, build...

Animal.java


public class Animal{

	...
	public static void main(String[] args) {
    		//mast have a main function as exec entry point ...
	}

}

child class of base class
Cat.java

public class Cat extends Animal{
    public Cat(){

    }
	//...
}

public class Dog extends Animal{
    public Dog(){

    }
	//...
 }

complier source codes 

go to cmd 
cd C:\Workarea\Java1

C:\Workarea\Java1>javac -d bin src\*.java

C:\Workarea\Java1>dir bin
 Volume in drive C is Windows
 Volume Serial Number is 485C-3B98

 Directory of C:\Workarea\Java1\bin

06/22/2019  11:07 PM    <DIR>          .
06/22/2019  11:07 PM    <DIR>          ..
06/23/2019  09:40 PM             3,222 Animal.class
06/23/2019  09:40 PM               260 Cat.class
06/23/2019  09:40 PM               260 Dog.class
               3 File(s)          3,742 bytes
               2 Dir(s)  118,356,910,080 bytes free


Only using java 11 or up to complier

C:\Users\henry.wang>java -version
java version "12.0.1" 2019-04-16
Java(TM) SE Runtime Environment (build 12.0.1+12)
Java HotSpot(TM) 64-Bit Server VM (build 12.0.1+12, mixed mode, sharing)


C:\Workarea\Java1>cd bin

run main class Animal

C:\Workarea\Java1\bin>java Animal
5 + 1 = 6
5 - 1 = 4
5 * 1 = 5
5 / 1 = 5
5 % 1 = 0
5 + 1 = 6
5 - 1 = 4
5 * 1 = 5
5 / 1 = 5
5 % 1 = 0
5 + 1 = 6
5 - 1 = 4
5 * 1 = 5
5 / 1 = 5
5 % 1 = 0
Woof
Moew

using jar to create exec file for java project

C:\Workarea\Java1>jar --create --file lib/demo.jar -C bin/ .

C:\Workarea\Java1>java -cp lib/demo.jar Animal
5 + 1 = 6
5 - 1 = 4
5 * 1 = 5
5 / 1 = 5
5 % 1 = 0
5 + 1 = 6
5 - 1 = 4
5 * 1 = 5
5 / 1 = 5
5 % 1 = 0
5 + 1 = 6
5 - 1 = 4
5 * 1 = 5
5 / 1 = 5
5 % 1 = 0
Woof
Moew

Add third party to java codes.

import org.apache.commons.lang3.text.WordUtiles;

org.apache cannot be resolved

Download common-lang3.jar - Java2s
http://www.java2s.com/Code/Jar/c/Downloadcommonlang3jar.htm

copy common-lang3 file to lib folder

Add Auto Import plugin to this java project to automatic add import.

recomplier the code include common-lang3.jar

C:\Workarea\Java1>javac -d bin -cp lib\common-lang3.jar src\*.java

or set CLASSPATH=C:\Workarea\Java1\lib
