# Testador de ips/ *Ips tester*
Testador de ips que identifica, dado uma lista de ips, identifica quais dispositivos estão ligados no momento.  
*(EN) Ip tester that given a list of ips the program will identify what ips are online in the moment.*  

#

## Instruções / *Instructions*

<details>
  <summary> BR </summary>

- Dentro do programa deve ser inserida o caminho da lista de endereços ou encontra-lo utilizando o botão com 3 pontos, exemplo de lista a baixo;  
- O programa verifica apenas 1 ip por linha;  
- O ip pode estar em qualquer posição da linha, o programa o encontrará.    

Após selecionar o arquivo contendo os endereços, basta clicar em "Executar", uma nova janela irá abrir perguntando quantos endereços deseja abrir simultaneamente, selecione a quantidade desejada e clique em "OK", em seguida o programa irá começar a realizar os testes a fim de detectar quais os dispositivos estão ligados, essa verificação é feita através da ferramenta de ping. Ao detectar um endereço ativo ele será aberto em uma janela do seu navegador, **o programa automaticamente remove endereços da lista após encontrá-lo ativo**.

</details>

<details>
  <summary> EN </summary>

- In the application it's necessary insert the path of the list or find the archive using the 3 dots button, example of list below;  
- The program just verify one ip per line;
- The ip can be in any position of the line, the application will find it.

After select or indicate the list, just click in "Executar" button and one box will ask you who many addresses you want to open in one time, just select in the number box and click in the "OK" button, the application will start test the ips to find which ips are online, this test is executed with the ping tool. The application will open the ip just if it's online, the ip will be on in your browser, **the application will automatically remove the ip of the list after open it.**

</details>

#

<details>
  <summary>Exemplo de lista / Example of list</summary>

Input
~~~
    127.0.0.1
    dns google: 8.8.8.8
    Este ip 192.168.0.1 deve ser testado
~~~
</details>