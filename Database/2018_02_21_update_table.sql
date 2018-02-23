-- Table: public.organization

-- DROP TABLE public.organization;

CREATE TABLE public.organization
(
  id integer NOT NULL DEFAULT nextval('organization_id_seq'::regclass),
  title text NOT NULL,
  is_commercial boolean,
  is_checked boolean,
  "create" time without time zone NOT NULL,
  modified time without time zone NOT NULL,
  create_by integer NOT NULL,
  city_id integer,
  country_id integer,
  is_active boolean NOT NULL,
  checked_by integer,
  CONSTRAINT organization_pkey PRIMARY KEY (id),
  CONSTRAINT organization_checked_by_fkey FOREIGN KEY (checked_by)
      REFERENCES public."user" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT organization_city_id_fkey FOREIGN KEY (city_id)
      REFERENCES public.city (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT organization_country_id_fkey FOREIGN KEY (country_id)
      REFERENCES public.country (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.organization
  OWNER TO postgres;
