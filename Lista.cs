using System;
using System.Collections.Generic;
using System.Text;


namespace Lista2deExercicios
{
    class Lista
    {
        //Atributos
        NohLista INICIO;
        NohLista FIM;

        //Metodos
        public Lista() { //construtor default
            INICIO = null;
            FIM = null;
        }

        public bool estaVazia() {
            if (INICIO == null && FIM == null) {
                return true;
            }
            else {
                return false;
            }
        }
        public void InsereInicio(int n) {
            NohLista newNoh = new NohLista(n);
            if (estaVazia()) {
                INICIO = newNoh;
                FIM = newNoh;
            }
            else {
                INICIO.setPrevio(newNoh);
                newNoh.setNext(INICIO);
                INICIO = newNoh;
            }
        }
        public void InsereApos(int _pos, int _data) {
            NohLista pos = encontraNoh(_pos);
            NohLista newNoh = new NohLista(_data);
            if (estaVazia()) {
                Console.WriteLine("A lista esta vazia");
            }
            else if(pos == null) {
                Console.WriteLine("Elemento nao encontrado");
            }
            else if(_pos == pos.getData()) {
                newNoh.setPrevio(pos);
                newNoh.setNext(pos.getNext());
                pos.setNext(newNoh);
                (newNoh.getNext()).setPrevio(newNoh);
                
            }
        }
        
        public int MaiorLista() {
            NohLista Maior = INICIO;
            NohLista aux = INICIO.getNext();

           //Console.WriteLine(INICIO.getData());
           //Console.WriteLine(aux.getData());
            
            while (aux != null) {
                if (Maior.getData() < aux.getData()) {
                    Maior = aux;
                }
                aux = aux.getNext();
            }
            return Maior.getData();
        }

        public void InsereFim(int n) {
            NohLista newNoh = new NohLista(n);
            if (estaVazia()) {
                INICIO = newNoh;
                FIM = newNoh;
            }
            else {
                FIM.setNext(newNoh);
                newNoh.setPrevio(FIM);
                FIM = newNoh;
            }
        }

        public void ImprimeEsqDireita() {
            if (estaVazia()) {
                Console.WriteLine("Lista vazia");
            }
            else {
                NohLista temp = INICIO;
                while (temp != null) {
                    Console.Write(temp.getData() + " ");
                    temp = temp.getNext();
                }
            }
        }
        public void ImprimeDireitaEsq() {
            if (estaVazia()) {
                Console.WriteLine("Lista vazia");
            }
            else {
                NohLista temp = FIM;
                while (temp != null) {
                    Console.Write(temp.getData() + " ");
                    temp = temp.getPrevio();
                }
            }
        }
        public NohLista encontraNoh(int _elemento) {
            NohLista foundNoh = INICIO;
            while (foundNoh != null) {
                if (foundNoh.getData() == _elemento) {
                    return (foundNoh);
                }
                else {
                    foundNoh = foundNoh.getNext();
                }
            }
            return null;
        }
        public void Remove(int n) {
            NohLista thisPtr = encontraNoh(n);
            if (thisPtr == INICIO) {
                INICIO = INICIO.getNext();
                INICIO.setPrevio(null);
            }
            else if (thisPtr == FIM) {
                FIM = FIM.getPrevio();
                FIM.setNext(null);
            }
            else {
                (thisPtr.getPrevio()).setNext(thisPtr.getNext());
                (thisPtr.getNext()).setPrevio(thisPtr.getPrevio());
            }
        }
    }
}
