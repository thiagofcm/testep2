using System;
using System.Collections.Generic;
using System.Text;

namespace Lista2deExercicios
{
    class NohLista
    {
        //atributos
        private NohLista previo;
        private int data;
        private NohLista next;

        //metodos
        public NohLista() { //construtor default
            previo = null;
            data = 0;
            next = null;
        }
        public NohLista(int n) { //construtor 
            previo = null;
            data = n;
            next = null;
        }
        //GETTERS AND SETTERS
        public NohLista getPrevio() {
            return previo;
        }
        public void setPrevio(NohLista _previo) {
            previo = _previo;
        }
        public int getData() {
            return data;
        }
        public void setData(int _data) {
            data = _data;
        }
        public NohLista getNext() {
            return next;
        }
        public void setNext(NohLista _next) {
            next = _next;
        }


    }
}
