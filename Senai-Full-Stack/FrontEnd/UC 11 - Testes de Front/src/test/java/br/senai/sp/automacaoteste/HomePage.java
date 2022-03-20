package br.senai.sp.automacaoteste;

import java.util.concurrent.TimeUnit;

import org.junit.Before;
import org.junit.After;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class HomePage {
	private WebDriver driver;
	
	@Before
	public void Setup() {
		System.setProperty("webdriver.chrome.driver", "C:\\Program Files\\chromedriver.exe");
		driver = new ChromeDriver();
		driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
		driver.manage().window().maximize();
	}
	
    /*@Test
    public void testeNavegarParaGoogle() {
    
    driver.get("https://online.sp.senai.br/");
    
    WebElement input =  driver.findElement(By.id("Busca1_txtFiltro"));
    
    input.sendKeys("gestao");
    //input.sendKeys(Keys.ENTER);

    driver.findElement(By.id("Busca1_btnBusca")).click();
    
    }
    
    @After
    public void FecharNavegador() {
    	driver.close();
    }*/
    
    @Test
    
    public void TestarLogin() {
    	driver.get("http://localhost:4200");
    	
    	driver.findElement(By.id("login")).click();
    	
    	//primeiro teste
    	
    	driver.findElement(By.id("emailcadastrado")).sendKeys("jklcw71@gmail.com");
    	driver.findElement(By.id("senhacadastrado")).sendKeys("batatinha123");
    	
    	driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);
    	
    	driver.findElement(By.id("botao_cadastrado")).click();
    	
    	WebElement mensagem = driver.findElement(By.id("mensagem"));
    	
    	System.out.println(mensagem.getText());
    }
    
    
 
    
}
