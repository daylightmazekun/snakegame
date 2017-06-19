namespace Snake
{
    public enum Direction{
        UP, DOWN, LEFT, RIGHT
    }

    public class SnakeModel{

        public LinkedList<Point> body = new LinkedList<Point>();
        private Direction direction;
        private Arena arena;

        private int growth = 2;

        Point speed = new Point();

        public SnakeModel(Arena arena){
            body.addLIst()
        }

    }
}