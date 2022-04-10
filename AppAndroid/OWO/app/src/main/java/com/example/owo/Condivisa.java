package com.example.owo;

public class Condivisa {
    String username;
    String password;
    static Condivisa _instance;
    static String path ="http://owowh.altervista.org/";

    private Condivisa() {
       username ="";
       password = "";
    }

    public static Condivisa getInstance() {
        if (_instance == null) {
            synchronized (Condivisa.class) {
                if (_instance == null) {
                    _instance = new Condivisa();
                }
            }
        }
        return _instance;
    }

}
