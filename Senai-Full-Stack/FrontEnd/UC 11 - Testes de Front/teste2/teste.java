package br.senai.testepagina;

import java.util.concurrent.TimeUnit;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class LoginGameManiaTest {

	private WebDriver driver;
	
	@Before
	public void Setup() {
		
		System.setProperty("webdriver.chrome.driver", "C:\\Program Files\\chromedriver\\chromedriver.exe");
		driver = new ChromeDriver();
		driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
		driver.manage().window().maximize();
	}
	@Test
	public void Teste() throws InterruptedException {
		
		// ----------------------- Cadastro de novos usuários ------------------------
		
		 // Acessa a página
		 driver.get("http://localhost:4200/");
		// redireciona para a página de cadastro e login
		driver.findElement(By.id("login")).click();
// espera a página ser carregada
driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);]
// seleciona o campo de e-mail e digita um e-mail válido

driver.findElement(By.id("naoemailcadastrado")).sendKeys("raissa@gmail.com");
// seleciona o campo de senha e digita uma senha válida

driver.findElement(By.id("naosenha1_1")).sendKeys("1234");
// seleciona o campo de redigitação de senha e digita a mesma senha

driver.findElement(By.id("naosenha2_1")).sendKeys("1234");
// seleciona o campo de CPF e digita um CPF válido

driver.findElement(By.id("naocpf1")).sendKeys("000.000.000-00");
// seleciona o CEP de senha e digita um CEP válido

driver.findElement(By.id("naocep1")).sendKeys("000.00-000");
// Espera por dois segundos

Thread.sleep(2000);
// Clica no botão e efetua o cadastro

driver.findElement(By.id(“naobotao_cadastrado”)).click();
// Espera por quatro segundos

Thread.sleep(4000);
// ******************  LOGIN DE USUÁRIO ********************
// Tenta se logar, mas com senha errada
email.clear();
email.sendKeys("raissa@hotmail.com");
Thread.sleep(4000);
senha.clear();
senha.sendKeys("1234");
Thread.sleep(4000);
driver.findElement(By.id(“botao_cadastrado”)).click();
Thread.sleep(4000);
	}