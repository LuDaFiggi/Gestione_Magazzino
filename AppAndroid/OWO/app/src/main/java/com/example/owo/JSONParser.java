package com.example.owo;


import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.Reader;
import java.net.URL;
import java.nio.charset.Charset;

public class JSONParser {
    public JSONParser() {

    }

    private static String readAll(Reader rd) throws IOException {
        StringBuilder sb = new StringBuilder();
        int cp;
        while ((cp = rd.read()) != -1) {
            sb.append((char) cp);
        }
        return sb.toString();
    }

    public static String readJsonFromUrl(String url) throws IOException, JSONException, FileNotFoundException {
        InputStream is = new URL(url).openStream();
        try {
            BufferedReader rd = new BufferedReader(new InputStreamReader(is, Charset.forName("UTF-8")));
            String jsonText = readAll(rd);
            return jsonText;
        } finally {
            is.close();
        }
    }

    public boolean getLoginResult(String username, String password) throws IOException, JSONException, InterruptedException {
        final boolean[] result = {false};
        Thread thread = new Thread(new Runnable() {

            @Override
            public void run() {
                Condivisa c = Condivisa.getInstance();
                try {
                    String jsonString = readJsonFromUrl("http://192.168.1.69/Marelli%20Samuele%205CI/AndroidTest/login.php?utente=" + c.username + "&password=" + c.password);
                    if (!jsonString.equals("")) {
                        JSONObject obj = new JSONObject(jsonString);
                        boolean ok = obj.getBoolean("result");
                        if (ok) {
                            result[0] = ok;
                        }
                    }
                } catch (Exception e) {
                    e.printStackTrace();
                }
                System.out.println("HO FINITO");
            }
        });

        thread.start();
        thread.join();
        return result[0];
    }
}
