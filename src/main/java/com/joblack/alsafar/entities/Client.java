package com.joblack.alsafar.entities;

import jakarta.persistence.*;
import lombok.Data;


@Data
@Entity
@Table(name = "client")
public class Client {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String name;

    private int age;

    private String email;

    @ManyToOne
    @JoinColumn(name = "tourPocket_id")
    private TourPocket tourPocket;

}
