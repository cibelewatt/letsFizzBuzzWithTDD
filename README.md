Projeto Final - Módulo Arquitetura de Software e Testes Automatizados

# Kata FizzBuzz
Escrever um programa que receba números inteiros. O retorno deverá ser o seguinte:
Se a entrada for um número múltiplo de 3 e de 5, retorna “FizzBuzz”
Caso contrário, se a entrada for um número múltiplo de 3, retorna “Fizz”
Caso contrário, se a entrada for um número múltiplo de 5, retorna “Buzz”
Caso contrário, retorna o próprio número.

Exemplo:
FizzBuzz fb = new FizzBuzz();
var text = fb.Of(15);
Console.WriteLine(text); // Escreve FizzBuzz

Observações
Use TDD
É obrigatório a presença de Testes Unitários
Pontos extras serão concedidos caso você utilize uma Console com Injeção de Dependência
Por exemplo: na classe Startup, injete a classe FizzBuzz

💡Sugestão para início:
1. Crie a Solution Em Branco
2. Adicione o Projeto de Domínio, sem nenhuma classe por enquanto
3. Adicione o Projeto de Testes
4. No Projeto de Testes, adicione uma referência para o Projeto de Domínio
5. No Projeto de Testes, adicione uma classe chamada FizzBuzzUnitTests
6. Na classe FizzBuzzUnitTests, crie um Método de Teste (um método que retorne void anotado com [Fact]) e, nesse método, crie uma instância da classe FizzBuzz. A classe ainda não existe, então o Teste está em Vermelho, isto é, não passa/executa.

Por exemplo:
[Fact]
public void FizzBuzz_Of15_ReturnsFizzBuzz()
{
FizzBuzz sut = new FizzBuzz();
}

7. Volte para o Projeto de Domínio e crie a classe FizzBuzz, de forma que o teste criado no passo 6 pare de dar erro de compilação.
8. Continue alternando entre os testes e a classe de "produção, sempre respeitando as regras do TDD, conforme preconizadas por Robert C. Martin (aka Uncle Bob) no Livro O Codificador Limpo:
a. Você não tem permissão para escrever nenhum código de produção até que primeiro tenha escrito um teste de unidade com falha
b. Você não tem permissão para escrever mais código em um teste de unidade do que o suficiente para fazer ele falhar - e não compilar significa
que está falhando.
c. Você não tem permissão para escrever mais código de produção do que o mínimo suficiente para passar no teste de unidade atualmente com falha
