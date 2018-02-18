-- Table: public.city

-- DROP TABLE public.city;

CREATE TABLE public.city
(
  id integer NOT NULL DEFAULT nextval('city_id_seq'::regclass),
  title text NOT NULL,
  country_id integer NOT NULL,
  CONSTRAINT city_pkey PRIMARY KEY (id),
  CONSTRAINT city_country_id_fkey FOREIGN KEY (country_id)
      REFERENCES public.city (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.city
  OWNER TO postgres;

  
-----------------------------------------


-- Table: public.country

-- DROP TABLE public.country;

CREATE TABLE public.country
(
  id integer NOT NULL DEFAULT nextval('country_id_seq'::regclass),
  title text NOT NULL,
  CONSTRAINT country_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.country
  OWNER TO postgres;

  
-----------------------------------------


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
  CONSTRAINT event_pkey PRIMARY KEY (id),
  CONSTRAINT event_city_id_fkey FOREIGN KEY (city_id)
      REFERENCES public.city (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT event_country_id_fkey FOREIGN KEY (country_id)
      REFERENCES public.country (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.event
  OWNER TO postgres;


-----------------------------------------


-- Table: public.event_history

-- DROP TABLE public.event_history;

CREATE TABLE public.event_history
(
  id integer NOT NULL DEFAULT nextval('event_history_id_seq'::regclass),
  event_id integer NOT NULL,
  additional_info text,
  change_id integer NOT NULL,
  CONSTRAINT event_history_pkey PRIMARY KEY (id),
  CONSTRAINT event_history_event_id_fkey FOREIGN KEY (event_id)
      REFERENCES public.event (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.event_history
  OWNER TO postgres;
  

-----------------------------------------


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
  is_free boolean,
  street text,
  home text,
  map_coordinate text,
  is_special_problem boolean,
  comment text,
  description text,
  CONSTRAINT event_info_pkey PRIMARY KEY (id),
  CONSTRAINT event_info_event_id_fkey FOREIGN KEY (event_id)
      REFERENCES public.event (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.event_info
  OWNER TO postgres;
  

-----------------------------------------


-- Table: public.event_organizer

-- DROP TABLE public.event_organizer;

CREATE TABLE public.event_organizer
(
  id integer NOT NULL DEFAULT nextval('event_organizer_id_seq'::regclass),
  event_id integer NOT NULL,
  photo text,
  user_id integer,
  description text,
  CONSTRAINT event_organizer_pkey PRIMARY KEY (id),
  CONSTRAINT event_organizer_event_id_fkey FOREIGN KEY (event_id)
      REFERENCES public.event (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.event_organizer
  OWNER TO postgres;


-----------------------------------------


-- Table: public.event_tags

-- DROP TABLE public.event_tags;

CREATE TABLE public.event_tags
(
  id integer NOT NULL DEFAULT nextval('event_tags_id_seq'::regclass),
  event_id integer NOT NULL,
  tag_id integer NOT NULL,
  CONSTRAINT event_tags_pkey PRIMARY KEY (id),
  CONSTRAINT event_tags_event_id_fkey FOREIGN KEY (event_id)
      REFERENCES public.event (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT event_tags_tag_id_fkey FOREIGN KEY (tag_id)
      REFERENCES public.tag (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.event_tags
  OWNER TO postgres;


-----------------------------------------


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
  CONSTRAINT organization_pkey PRIMARY KEY (id),
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

  
-----------------------------------------


-- Table: public.organization_info

-- DROP TABLE public.organization_info;

CREATE TABLE public.organization_info
(
  id integer NOT NULL DEFAULT nextval('organization_info_id_seq'::regclass),
  organization_id integer NOT NULL,
  inn text,
  address text, -- 
  phone1 text,
  phone2 text,
  photo text,
  street text,
  contact_face_id integer,
  contact_info text,
  is_private boolean, -- the owner is a private face or a legal entity
  CONSTRAINT organization_info_pkey PRIMARY KEY (id),
  CONSTRAINT organization_info_organization_id_fkey FOREIGN KEY (organization_id)
      REFERENCES public.organization (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.organization_info
  OWNER TO postgres;
COMMENT ON COLUMN public.organization_info.address IS '
';
COMMENT ON COLUMN public.organization_info.is_private IS 'the owner is a private face or a legal entity';


-----------------------------------------


-- Table: public.role

-- DROP TABLE public.role;

CREATE TABLE public.role
(
  id integer NOT NULL DEFAULT nextval('role_id_seq'::regclass),
  title text,
  CONSTRAINT role_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.role
  OWNER TO postgres;

  
-----------------------------------------


-- Table: public.tag

-- DROP TABLE public.tag;

CREATE TABLE public.tag
(
  id integer NOT NULL DEFAULT nextval('tag_id_seq'::regclass),
  title text NOT NULL,
  CONSTRAINT tag_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.tag
  OWNER TO postgres;


-----------------------------------------


-- Table: public.ticket

-- DROP TABLE public.ticket;

CREATE TABLE public.ticket
(
  id integer NOT NULL DEFAULT nextval('ticket_id_seq'::regclass),
  event_id integer NOT NULL,
  totaly_count integer NOT NULL,
  residue integer NOT NULL,
  residue_with_discount integer,
  promocode text,
  title text NOT NULL,
  price text,
  CONSTRAINT ticket_pkey PRIMARY KEY (id),
  CONSTRAINT ticket_event_id_fkey FOREIGN KEY (event_id)
      REFERENCES public.event (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.ticket
  OWNER TO postgres;

  
-----------------------------------------


-- Table: public."user"

-- DROP TABLE public."user";

CREATE TABLE public."user"
(
  id integer NOT NULL DEFAULT nextval('user_id_seq'::regclass),
  title text NOT NULL,
  city_id integer,
  country_id integer,
  role_id integer NOT NULL,
  CONSTRAINT user_pkey PRIMARY KEY (id),
  CONSTRAINT user_city_id_fkey FOREIGN KEY (city_id)
      REFERENCES public.city (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT user_country_id_fkey FOREIGN KEY (country_id)
      REFERENCES public.country (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT user_role_id_fkey FOREIGN KEY (role_id)
      REFERENCES public.role (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public."user"
  OWNER TO postgres;


-----------------------------------------


-- Table: public.user_info

-- DROP TABLE public.user_info;

CREATE TABLE public.user_info
(
  id integer NOT NULL DEFAULT nextval('user_info_id_seq'::regclass),
  user_id integer NOT NULL,
  first_name text,
  second_name text,
  thied_name text,
  full_name text,
  phone1 text,
  phone2 text,
  photo text,
  street text,
  comment text,
  CONSTRAINT user_info_pkey PRIMARY KEY (id),
  CONSTRAINT user_info_user_id_fkey FOREIGN KEY (user_id)
      REFERENCES public."user" (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE public.user_info
  OWNER TO postgres;


-----------------------------------------