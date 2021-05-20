programa
{
	
	funcao inicio()
	{
		inteiro vetor[] = {1,3,5,7,9}//inicializa o vetor
		inteiro numero //declara variável numero 
		logico presente = falso //valor para indicar a presença do numero no vetor
		escreva("Digite o número que deseja procurar: ")
		leia(numero)//recebendo o numero que será buscado
		para(inteiro posicao=0;posicao<5;posicao++){//percorre o vetor
			se(numero == vetor[posicao]){//verifica se o numero foi encontrado
				presente = verdadeiro
				escreva("Numero encontrado na posicao "+posicao)
				pare	//para a busca quando o numero é encontrado
			}		
		}
		se(nao presente){//comunica que o numeor foi achado
			escreva("Numero não encontrado")	
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 686; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */