package com.example.owo;

import org.json.JSONObject;
import org.w3c.dom.Document;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

import java.io.IOException;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

public class XMLParser {

    public XMLParser()
    {

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
}
