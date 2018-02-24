-- Table: public.event_type

-- DROP TABLE public.event_type;

CREATE TABLE public.event_type
(
  id integer NOT NULL DEFAULT nextval('event_type_id_seq'::regclass),
  title text,
  CONSTRAINT event_type_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.event_type
  OWNER TO postgres;

-------------------------------------------------
  
  
-- Table: public.event

-- DROP TABLE public.event;

CREATE TABLE public.event
(
  id integer NOT NULL DEFAULT nextval('event_id_seq'::regclass),
  title text NOT NULL,
  start time without time zone NOT NULL,
  finish time without time zone NOT NULL,
  photo text,
  country_id integer,
  city_id integer,
  is_checked boolean,
  is_active boolean,
  reduced_description text NOT NULL,
  type_id integer,
  is_free boolean,
  CONSTRAINT event_pkey PRIMARY KEY (id),
  CONSTRAINT event_city_id_fkey FOREIGN KEY (city_id)
      REFERENCES public.city (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT event_country_id_fkey FOREIGN KEY (country_id)
      REFERENCES public.country (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT event_type_id_fkey FOREIGN KEY (type_id)
      REFERENCES public.event_type (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.event
  OWNER TO postgres;

-- Index: public.type_id

-- DROP INDEX public.type_id;

CREATE INDEX type_id
  ON public.event
  USING btree
  (type_id);




-------------------------------------------------

-- Table: public.event_info

-- DROP TABLE public.event_info;

CREATE TABLE public.event_info
(
  id integer NOT NULL DEFAULT nextval('event_info_id_seq'::regclass),
  event_id integer NOT NULL,
  "create" time without time zone NOT NULL,
  modified time without time zone NOT NULL,
  create_by integer NOT NULL,
  admin integer NOT NULL,
  moderator integer NOT NULL,
  street text,
  house text,
  map_coordinate text,
  is_special_problem boolean,
  comment text,
  description text,
  modified_by integer,
  CONSTRAINT event_info_pkey PRIMARY KEY (id),
  CONSTRAINT event_info_admin_fkey FOREIGN KEY (admin)
      REFERENCES public."user" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT event_info_create_by_fkey FOREIGN KEY (create_by)
      REFERENCES public."user" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT event_info_event_id_fkey FOREIGN KEY (event_id)
      REFERENCES public.event (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT event_info_moderator_fkey FOREIGN KEY (moderator)
      REFERENCES public."user" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT event_info_modified_by_fkey FOREIGN KEY (modified_by)
      REFERENCES public."user" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.event_info
  OWNER TO postgres;
