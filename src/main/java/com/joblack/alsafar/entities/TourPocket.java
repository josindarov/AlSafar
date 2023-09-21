package com.joblack.alsafar.entities;


import jakarta.persistence.*;
import lombok.Data;

import java.time.LocalDate;
import java.util.List;

@Data
@Entity
@Table(name = "tour_pocket")
public class TourPocket {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String destination;

    private int length;

    private LocalDate startDate;

    private LocalDate endDate;

    private Double price;

    private Long numberOfSeats;

    @ManyToOne
    @JoinColumn(name = "tourFirms_id")
    private TourFirm tourFirm;

    @OneToMany(mappedBy = "tourPocket")
    private List<Client> clients;
}
