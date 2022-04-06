package com.example.owo;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.wifi.WifiManager;
import android.os.Bundle;
import android.os.Handler;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;

import org.json.JSONException;
import org.json.JSONObject;
import org.xml.sax.SAXException;

import java.io.IOException;
import java.sql.SQLException;

import javax.xml.parsers.ParserConfigurationException;

public class MainActivity extends AppCompatActivity {

    private static final String url = "jdbc:mysql://192.168.1.69:3306/test_android";
    private static final String user = "any";
    private static final String pass = "";
    Button submit;
    ProgressBar round;
    Condivisa c;
    WifiManager wifiManager;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        c = Condivisa.getInstance();
        EditText username = findViewById(R.id.username);
        EditText password = findViewById(R.id.password);
        round = findViewById(R.id.progressBar3);
        round.setVisibility(View.INVISIBLE);
        username.setText(c.username);
        submit = findViewById(R.id.submit);
        submit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //check testo textbox
                round.setVisibility(View.VISIBLE);
                try {
                    boolean ok = checkLogIn();
                    if (ok)
                        openNewActivity();
                    else {
                        round.setVisibility(View.INVISIBLE);
                        createAlert("ERROR!", "Credenziali errate");
                    }
                } catch (
                        JSONException e) {
                    e.printStackTrace();
                } catch (
                        IOException e) {
                    createAlert("ERROR!", e.toString());
                } catch (
                        ParserConfigurationException e) {
                    createAlert("ERROR!", e.toString());
                } catch (
                        SAXException e) {
                    createAlert("ERROR!", e.toString());
                } catch (
                        InterruptedException e) {
                    createAlert("ERROR!", e.toString());
                }
            }

        });
    }


    public void createAlert(String title, String message) {
        AlertDialog.Builder builder
                = new AlertDialog
                .Builder(MainActivity.this);
        builder.setMessage(message);
        builder.setTitle(title);
        builder.setCancelable(true);
        AlertDialog alertDialog = builder.create();
        alertDialog.show();
    }

    public boolean checkLogIn() throws
            JSONException, IOException, ParserConfigurationException, SAXException, InterruptedException {
        EditText u = findViewById(R.id.username);
        EditText p = findViewById(R.id.password);
        c.username = u.getText().toString();
        c.password = p.getText().toString();
        JSONParser jp = new JSONParser();
        boolean result = jp.getLoginResult(c.username, c.password);
        return result;
    }

    public void openNewActivity() {
        Intent intent = new Intent(this, SubmitActivity.class);
        startActivity(intent);
    }
}