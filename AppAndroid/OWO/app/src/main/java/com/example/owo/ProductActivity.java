package com.example.owo;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.EditText;

import org.xml.sax.SAXException;

import java.io.IOException;
import java.util.List;

import javax.xml.parsers.ParserConfigurationException;

public class ProductActivity extends AppCompatActivity {

    Condivisa c = Condivisa.getInstance();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_product);
        try {
            getAllProducts();
        } catch (ParserConfigurationException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (SAXException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

    public List<Product> getAllProducts() throws ParserConfigurationException, IOException, SAXException, InterruptedException {
        XMLParser xml = new XMLParser();
        String path = Condivisa.path + "getAllProdotti.php?email=" + c.username + "&password=" + c.password;
        return xml.Parse_allProduct(path);
    }
}