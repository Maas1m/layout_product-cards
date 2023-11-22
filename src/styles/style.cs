body {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: Roboto, sans-serif;
}

.card {
  width: 198px;
  border-radius: 5px;
  border: 1px solid #F3F3F3;
  background: #FFF;
}

.card__image {
  width: 160px;
  height: 134px;
  margin: 33px 20px 40px;
}

.card__title {
  color: #060B35;
  font-size: 12px;
  font-style: normal;
  font-weight: 500;
  line-height: 18px;
  margin: 0 16px 4px;
}

.title {
  color: #616070;
  font-size: 10px;
  font-style: normal;
  font-weight: 400;
  line-height: 14px;
  margin: 0 16px;
}

.review {
  display: flex;
  width: 166px;
  justify-content: space-between;
  align-items: flex-end;
  margin: 16px 16px 24px;
}

.reviews {
  color: #060B35;
  text-align: right;
  font-size: 10px;
  font-style: normal;
  font-weight: 400;
  line-height: 14px;
  margin: 0;
}

.price {
  display: flex;
  height: 18px;
  width: 166px;
  justify-content: space-between;
  align-items: flex-end;
  margin: 0;
  margin-right: 16px;
  margin-left: 16px;
}

.price__title {
  color: #616070;
  font-size: 12px;
  font-style: normal;
  font-weight: 400;
  margin: 0;
  line-height: 18px;
}

.cost {
  color: #060B35;
  text-align: right;
  font-size: 16px;
  font-style: normal;
  margin: 0;
  font-weight: 700;
  line-height: 18px;
}

.button {
  border-radius: 5px;
  background: #00ACDC;
  width: 166px;
  height: 40px;
  margin: 16px;
  border: #00ACDC;
}

.button:hover {
  border-radius: 5px;
  transition: 300ms;
  border: 1px solid #00ACDC;
  background: #FFF;
}

.button__title {
  color: #FFF;
  text-align: center;
  border-color: white;
  font-size: 14px;
  margin: 0;
  font-style: normal;
  font-weight: 700;
  line-height: 16px;
  text-transform: uppercase;
  text-decoration: none;
}

.button__title:hover {
  color: #00ACDC;
  transition: 300ms;
}

.stars {
  display: flex;
  background-image: url(images/Stars.svg);
}

.stars__star {
  background-image: url(images/star.svg);
  width: 16px;
  height: 16px;
  background-position: center;
  background-repeat: no-repeat;
  margin-right: 4px;
}

.stars__star:last-child {
  margin-right: 0;
}

/*# sourceMappingURL=style.cs.map */
