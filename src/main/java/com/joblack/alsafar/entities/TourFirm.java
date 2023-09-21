package com.joblack.alsafar.entities;

import jakarta.persistence.*;
import lombok.Data;
import org.antlr.v4.runtime.misc.NotNull;

import java.util.List;

@Data
@Entity
@Table(name = "tour_firm")
public class TourFirm {


    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @NotNull
    private String name;

    @NotNull
    private String email;

    @OneToMany(mappedBy = "tourFirm", cascade = CascadeType.ALL)
    private List<TourPocket> tourPocketList;
}
