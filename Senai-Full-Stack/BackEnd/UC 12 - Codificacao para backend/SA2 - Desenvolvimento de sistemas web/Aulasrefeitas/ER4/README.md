# ER4 Validar CNPJ

## Expressão Regular (Regex)  

### Regex
 
A biblioteca de expressões regulares é utilizada pelo argumento REGEX, note que é necessário o using das expressões regulares.

Guia de Expressões regulares:https://docs.microsoft.com/pt-br/dotnet/standard/base-types/regular-expression-language-quick-reference

_**Regex-Generator**_ - Existem vários sites na internet que geram automaticamente a expressão regular.

### Métodos Regex

- _**IsMatch**_ - é um método do REGEX que compara uma string a uma expressão regular, ou seja compara se uma informação de texto veio em um formato específico. A sintaxe é dada por  

**Regex.IsMatch(stringRecebida,formatoEsperado)**. Exemplo:

```
  using System.Text.RegularExpressions;
       
    public bool validarCnpj(string cnpj)
        {
            if (cnpj, @"\d{2}.\d{3}.\d{3}/\d{4}-\d{2}"))
            {
                
            }
        }
```

Neste exemplo acima o formato esperado é XX.XXX.XXX/XXXX-XX.  


- _**IsMatch**_ - é um método do REGEX que compara uma string a uma expressão regular, ou seja compara se uma informação de texto veio em um formato específico. A sintaxe é dada por  

----------------------------------------------------------------------

## Métodos

- _**Substring**_ - é um método que separa uma string em uma menor a partir de um certo caracter. A sintaxe é dada da seguinte forma:

nomeDaString.Substring(int startIndex)  

Exemplo:  

```
 cnpj.Substring(5)
```
Este exemplo receberia uma string de nome **cnpj** e formaria uma subtring a partir do quinto caractere. "Rabanada" se tornaria "ada".

```
 cnpj.Substring(5,2)
```

Este exemplo receberia uma string de nome **cnpj** e formaria uma subtring a partir do quinto caractere com um tamanho total de 4 caracteres. "Rabanada" se tornaria "ad".





































