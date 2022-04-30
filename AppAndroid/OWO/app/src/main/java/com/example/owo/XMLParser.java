package com.example.owo;

import org.json.JSONObject;
import org.w3c.dom.Document;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

public class XMLParser {

    public XMLParser() {

    }

    public String Parse_Login(String path) throws ParserConfigurationException, SAXException, IOException, InterruptedException {
        final String[] csv = {""};
        Thread thread = new Thread(new Runnable() {

            @Override
            public void run() {
                Condivisa c = Condivisa.getInstance();
                try {
                    DocumentBuilderFactory factory;
                    DocumentBuilder builder;
                    Node root, element;
                    NodeList nodeList;
                    factory = DocumentBuilderFactory.newInstance();
                    builder = factory.newDocumentBuilder();
                    Document document = builder.parse(path);
                    root = document.getDocumentElement();
                    nodeList = document.getElementsByTagName("Mess");
                    csv[0] = nodeList.item(0).getTextContent();
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });

        thread.start();
        thread.join();
        return csv[0];
    }

    public List<Product> Parse_allProduct(String path) throws ParserConfigurationException, SAXException, IOException, InterruptedException {
        final List<Product> products = new ArrayList();
        Thread thread = new Thread(new Runnable() {

            @Override
            public void run() {
                Condivisa c = Condivisa.getInstance();
                try {
                    DocumentBuilderFactory factory;
                    DocumentBuilder builder;
                    Node root, element;
                    NodeList nodeList;
                    factory = DocumentBuilderFactory.newInstance();
                    builder = factory.newDocumentBuilder();
                    Document document = builder.parse(path);
                    root = document.getDocumentElement();
                    nodeList = document.getElementsByTagName("Prodotto");
                    for (int i = 0; i < nodeList.getLength(); i++) {
                        Node n = nodeList.item(i);
                        NodeList temp = n.getChildNodes();
                        if (temp.getLength() > 0) {
                            Product prod = new Product();
                            prod.setCodProdotto((Integer.parseInt(temp.item(0).getTextContent())));
                            prod.setQRCdde(((temp.item(1).getTextContent())));
                            prod.setQuantita(Integer.parseInt(temp.item(2).getTextContent()));
                            prod.setNome((temp.item(3).getTextContent()));
                            prod.setDescrizione(((temp.item(4).getTextContent())));
                            prod.setPrezzoUnita((Double.parseDouble(temp.item(5).getTextContent())));
                            prod.setCodScaffale((Integer.parseInt(temp.item(6).getTextContent())));
                            prod.setCodFornitore((Integer.parseInt(temp.item(7).getTextContent())));
                            products.add(prod);
                        }
                    }
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });

        thread.start();
        thread.join();
        return products;
    }
}
