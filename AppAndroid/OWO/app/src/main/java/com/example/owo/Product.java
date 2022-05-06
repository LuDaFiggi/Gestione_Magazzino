package com.example.owo;

public class Product {
    private int CodProdotto;
    private String QRCdde;
    private int Quantita;
    private String nome;
    private String descrizione;
    private double prezzoUnita;
    private int CodScaffale;
    private int CodFornitore;

    public Product() {
        CodProdotto = 0;
        QRCdde = "";
        Quantita = 0;
        nome = "";
        descrizione = "";
        prezzoUnita = 0.0;
        CodScaffale = 0;
        CodFornitore = 0;

    }

    public int getCodProdotto() {
        return CodProdotto;
    }

    public void setCodProdotto(int codProdotto) {
        CodProdotto = codProdotto;
    }

    public String getQRCdde() {
        return QRCdde;
    }

    public void setQRCdde(String QRCdde) {
        this.QRCdde = QRCdde;
    }

    public int getQuantita() {
        return Quantita;
    }

    public void setQuantita(int quantita) {
        Quantita = quantita;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getDescrizione() {
        return descrizione;
    }

    public void setDescrizione(String descrizione) {
        this.descrizione = descrizione;
    }

    public double getPrezzoUnita() {
        return prezzoUnita;
    }

    public void setPrezzoUnita(double prezzoUnita) {
        this.prezzoUnita = prezzoUnita;
    }

    public int getCodScaffale() {
        return CodScaffale;
    }

    public void setCodScaffale(int codScaffale) {
        CodScaffale = codScaffale;
    }

    public int getCodFornitore() {
        return CodFornitore;
    }

    public void setCodFornitore(int codFornitore) {
        CodFornitore = codFornitore;
    }
}
