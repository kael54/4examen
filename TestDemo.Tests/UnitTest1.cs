namespace TestDemo.Tests;

public class UnitTest1
{
[Fact]  

public void EsferaTest() {  

//Arrange  

var num1 = 6;   

var expectedResult = 904.7786842338603;  

//Act  

var result = Mathematics.Esfera(num1);  

//Assert  

Assert.Equal(expectedResult, result, 3);  

}  

[Fact]  

public void LoteTest() { 

//Arrange  
  
var num1 = 5;    

var num2 = 5;    

var expectedResult = 25;  

//Act  

var result = Mathematics.Lote(num1,num2);  

//Assert  

Assert.Equal(expectedResult, result);  
} 

[Fact]  

public void EdificioTest() { 

//Arrange  
  
var num1 = 50;  

var num2 = 30;  

var expectedResult = 28.867513459481287;

//Act  

var result = Mathematics.Edificio(num1, num2);  

//Assert  
double tolerance = 0.01;

Assert.Equal(expectedResult, result,tolerance);  

}  

}
