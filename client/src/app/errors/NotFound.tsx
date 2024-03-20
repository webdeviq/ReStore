import { Button, Container, Divider, Paper, Typography } from "@mui/material";
import { Link } from "react-router-dom";

const NotFound = () => {
  return (
    <Container component={Paper} sx={{ height: 80 }}>
      <Typography gutterBottom variant="h3">
        Oops we could not find what you are looking for
      </Typography>
      <Divider />
      <Button fullWidth component={Link} to="/catalog">
        Go Back To Shop
      </Button>
    </Container>
  );
};

export default NotFound;
