CREATE TABLE tour_firm (
                           id SERIAL PRIMARY KEY,
                           name VARCHAR(255) NOT NULL,
                           email VARCHAR(255) NOT NULL
);

CREATE TABLE tour_pocket (
                             id SERIAL PRIMARY KEY,
                             destination VARCHAR(255),
                             length INT,
                             start_date DATE,
                             end_date DATE,
                             price DOUBLE PRECISION,
                             number_of_seats BIGINT,
                             tourFirms_id BIGINT,
                             FOREIGN KEY (tourFirms_id) REFERENCES tour_firm(id)
);

CREATE TABLE client (
                        id SERIAL PRIMARY KEY,
                        name VARCHAR(255),
                        age INT,
                        email VARCHAR(255),
                        tourPocket_id BIGINT,
                        FOREIGN KEY (tourPocket_id) REFERENCES tour_pocket(id)
);
