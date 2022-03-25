# Testador de ips/ Ips tester
Testador de ips que identifica, dado uma lista de ips, quais dispositivos estão ligados no momento.

#
## Como utilizar:

### Arquivo lista.txt

- Dentro do arquivo deve ser inserida a lista de endereços ips a serem testados;  
- O programa verifica apenas 1 ip por linha;  
- O ip pode estar em qualquer posição da linha, o programa o encontrará.    

Após selecionar o arquivo contendo os endereços, basta clicar em abrir e o progrma irá começar a realizar os testes a fim de detectar quais os dispositivos estão ligados, essa verificação é feita através da ferramenta de ping do próprio windows. Ao detectar um endereço ativo ele será aberto em uma janela do seu navegador, **o programa automaticamente remove endereços da lista após encontrá-lo ativo**.