package com.example.owo;

import java.util.ArrayList;
import java.util.List;

public class Condivisa {
    String username;
    String password;
    static Condivisa _instance;
    static String path = "http://owowh.altervista.org/webservice/";
    List<Product> products;

    private Condivisa() {
        username = "";
        password = "";
        products = new ArrayList<Product>();
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
