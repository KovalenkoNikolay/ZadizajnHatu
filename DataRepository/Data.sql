INSERT INTO public."DesignStudioPriceType"(
	"Id", "Name")
	VALUES (1, 'Standard');



INSERT INTO public."DesignStudios"(
	"Id", "Name", "CoverName", "AppUserId")
	VALUES ('e4b24e70-cee1-4a8f-a31a-4f607e70e642', 'Veranda Design Studio', 1, null);
	
INSERT INTO public."DesignStudios"(
	"Id", "Name", "CoverName", "AppUserId")
	VALUES ('81c3671e-ef4d-4b59-9cb2-a1ce4b0d7ae3', 'Mahno', 2, null);
	
INSERT INTO public."DesignStudios"(
	"Id", "Name", "CoverName", "AppUserId")
	VALUES ('90ef9276-a79b-4533-b64e-90d8cb3c671b', 'Natali', 3, null);



INSERT INTO public."DesignStudioPrice"(
	"Id", "MinPrice", "DesignStudioId", "PriceTypeId")
	VALUES ('e4b24e70-cee1-4a8f-a31a-4f607e70e642', 20, 'e4b24e70-cee1-4a8f-a31a-4f607e70e642', 1);

INSERT INTO public."DesignStudioPrice"(
	"Id", "MinPrice", "DesignStudioId", "PriceTypeId")
	VALUES ('b1ac2cd5-dd0d-4442-a935-dea2e08a3053', 10, '81c3671e-ef4d-4b59-9cb2-a1ce4b0d7ae3', 1);
	
INSERT INTO public."DesignStudioPrice"(
	"Id", "MinPrice", "DesignStudioId", "PriceTypeId")
	VALUES ('dd0ba373-0dad-4a53-9025-fe845f499b49', 15, '90ef9276-a79b-4533-b64e-90d8cb3c671b', 1);



INSERT INTO public."DesignStudioPortfolio"(
	"Id","Name", "Description", "DesignStudioId")
	VALUES ('56f556d5-0673-423e-bfc0-9b2aa4bbd237', 'ЖК Комфорт-Таун', 'Дизайн проект для наших клиентов', 'e4b24e70-cee1-4a8f-a31a-4f607e70e642');



INSERT INTO public."DesignStudioImage"(
	"Id", "Name", "FileName", "DesignStudioPortfolioId")
	VALUES ('c2fa88c1-9e33-4530-a721-11214ed4e921', 'Кухня', '1', '56f556d5-0673-423e-bfc0-9b2aa4bbd237');

INSERT INTO public."DesignStudioImage"(
	"Id", "Name", "FileName", "DesignStudioPortfolioId")
	VALUES ('83f6766c-b9d8-4d06-9156-8c598eacf6ba', 'Спальня', '2', '56f556d5-0673-423e-bfc0-9b2aa4bbd237');

INSERT INTO public."DesignStudioImage"(
	"Id", "Name", "FileName", "DesignStudioPortfolioId")
	VALUES ('4ce6f455-0b5e-4211-8f84-27887216860c', 'Ванная', '3', '56f556d5-0673-423e-bfc0-9b2aa4bbd237');