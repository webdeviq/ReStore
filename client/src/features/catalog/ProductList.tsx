import { Grid } from "@mui/material";
import { IProduct } from "../../app/models/product";
import ProductCard from "./ProductCard";

interface IProductListProps {
  products: IProduct[];
}

const ProductList = ({ products }: IProductListProps) => {
  return (
    <Grid container spacing={4}>
      {products.map((product) => (
        <Grid item xs={3} key={product.id}>
          <ProductCard product={product} />
        </Grid>
      ))}
    </Grid>
  );
};

export default ProductList;
