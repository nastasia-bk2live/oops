#include <iostream>
#include <cstdlib> 
#include <ctime>
#include <windows.h>
#include <fstream>


using namespace std;

int world[100][100];
int prev_world[100][100];



//Инициализация первого поколения игры псевдослучайными значениями
void init_world_rand(int world_height, int world_width);

//Инициализация первого поколения игры из файла
void init_world_fail(int world_height, int world_width);

// Вывести на экран игровое поле
void print_world(int world_height, int world_width);

//Количество живых клеток на игровом поле
int get_live_count(int world_height, int world_width);

//Копирование игрового мира. Используется для сохранения предыдущего поколения
void copy_world(int world_height, int world_width);

//Сравнение игровых миров текущего и предыдущего поколения
int cmp_world(int world_height, int world_width);

//тор

// Получение координат соседей точки 
void read_point_neighbors_tor(int coordinates_nb[][2], int x, int y, int world_height, int world_width);

//Количество живых соседей у клетки с координатами x, y
int count_live_neighbors_tor(int x, int y, int world_height, int world_width);

//Сгенерировать следующее поколение игрового мира
void next_generation_tor(int world_height, int world_width);

//ограниченное поле

// Получение координат соседей точки 
void read_point_neighbors(int coordinates_nb[][2], int x, int y, int world_height, int world_width);

//Количество живых соседей у клетки с координатами x, y
int count_live_neighbors(int x, int y, int world_height, int world_width);

//Сгенерировать следующее поколение игрового мира
void next_generation(int world_height, int world_width);

int main()
{
	setlocale(LC_ALL, "Russian");
	int world_height, world_width, p, q;
	cout << "Введите размеры поля" << endl;
	cout << "высота: ";
	cin >> world_height;
	cout << "ширина: ";
	cin >> world_width;

	cout << endl << "Выберете разметку поля" << endl << "1: ограниченное поле" << endl << "2: тор" << endl << "-> ";
	cin >> p;

	cout << endl << "Выберете способ генерации первого поколения" << endl << "1: случайная генерация" << endl << "2: из файла" << endl << "-> ";
	cin >> q;
	if (q == 1) {
		init_world_rand(world_height, world_width);
	}
	else if (q == 2) {
		init_world_fail(world_height, world_width);
	}

	int live_points = -1;
	bool is_optimal = false;
	system("cls");
	if (p == 1) {
		do {
			print_world(world_height, world_width);
			copy_world(world_height, world_width);
			next_generation(world_height, world_width);

			is_optimal = cmp_world(world_height, world_width) == 0;
			live_points = get_live_count(world_height, world_width);

			Sleep(1000);
			system("cls");

			if (is_optimal)
				cout << "Остались только устойчевые фигуры" << endl;

			if (live_points == 0)
				cout << "Все клетки умерли" << endl;

		} while (live_points != 0 && !is_optimal);
	}
	else if (p == 2) {
		do {
			print_world(world_height, world_width);
			copy_world(world_height, world_width);
			next_generation_tor(world_height, world_width);

			is_optimal = cmp_world(world_height, world_width) == 0;
			live_points = get_live_count(world_height, world_width);

			Sleep(1000);
			system("cls");

			if (is_optimal)
				cout << "Остались только устойчевые фигуры" << endl;

			if (live_points == 0)
				cout << "Все клетки умерли" << endl;

		} while (live_points != 0 && !is_optimal);
	}
	return 0;
}

//Инициализация первого поколения игры из файла
void init_world_fail(int world_height, int world_width) {
	ifstream fin;
	fin.open("first.txt");
	if (!fin.is_open()) {
		cout << "Ошибка открытия файла!" << endl;
	}
	else {
		char ch;
		for (int i = 0; i < world_height; i++) {
			for (int j = 0; j < world_width; j++) {
				fin.get(ch);
				if (ch == 'o')
					world[i][j] = 0;
				else if (ch == 'x')
					world[i][j] = 1;
			}
		}
	}
	fin.close();
}



//Инициализация первого поколения игры псевдослучайными значениями
void init_world_rand(int world_height, int world_width)
{
	srand(static_cast<unsigned int>(time(0)));

	for (int i = 0; i < world_height; i++) {
		for (int j = 0; j < world_width; j++) {
			int num = rand();
			if (num % 2 == 0)
				world[i][j] = 1;
			else
				world[i][j] = 0;
		}
	}
}



//Вывести на экран игровое поле
void print_world(int world_height, int world_width)
{

	for (int i = 0; i < world_height; i++) {
		for (int j = 0; j < world_width; j++) {
			if (world[i][j] == 1)
				cout << 'o';
			else
				cout << ' ';
			cout << ' ';
		}
		cout << endl;
	}
}



//Количество живых клеток на игровом поле
int get_live_count(int world_height, int world_width)
{
	unsigned int count = 0;
	for (int i = 0; i < world_height; i++)
		for (int j = 0; j < world_width; j++)
			if (world[i][j] == 1)
				count++;
	return count;
}



//Получение координат соседей точки (тор)
void read_point_neighbors_tor(int coordinates_nb[][2], int x, int y, int world_height, int world_width)
{
	int k = 0;

	for (int i = x - 1; i <= x + 1; i++) {
		for (int j = y - 1; j <= y + 1; j++) {
			if (i == x && j == y)
				continue;
			if (i == -1)
				coordinates_nb[k][0] = world_width + i;
			else if (i == world_width) coordinates_nb[k][0] = world_width - i;
			else coordinates_nb[k][0] = i;
			if (j == -1)
				coordinates_nb[k][1] = world_height + j;
			else if (i == world_width) coordinates_nb[k][1] = world_height - j;
			else coordinates_nb[k][1] = j;
			k++;
		}
	}
}



//Количество живых соседей у клетки с координатами x, y (тор)
int count_live_neighbors_tor(int x, int y, int world_height, int world_width)
{
	int count = 0;
	int coordinates_nb[8][2];
	int _x, _y;

	read_point_neighbors_tor(coordinates_nb, x, y, world_height, world_width);

	for (int i = 0; i < 8; i++) {
		_x = coordinates_nb[i][0];
		_y = coordinates_nb[i][1];

		if (prev_world[_x][_y] == 1)
			count++;
	}

	return count;
}



//Генерировать следующее поколение игрового мира (тор)
void next_generation_tor(int world_height, int world_width)
{
	int live_nb;
	int p;

	for (int i = 0; i < world_height; i++) {
		for (int j = 0; j < world_width; j++) {
			p = prev_world[i][j];
			live_nb = count_live_neighbors_tor(i, j, world_height, world_width);

			if (p == 0) {
				if (live_nb == 3)
					world[i][j] = 1;
			}
			else
				if (live_nb < 2 || live_nb > 3)
					world[i][j] = 0;
		}
	}
}



//Копирование игрового мира. Используется для сохранения предыдущего поколения
void copy_world(int world_height, int world_width)
{
	for (int i = 0; i < world_height; i++)
		for (int j = 0; j < world_width; j++)
			prev_world[i][j] = world[i][j];
}



//Сравнение игровых миров текущего и предыдущего поколения
int cmp_world(int world_height, int world_width)
{
	for (int i = 0; i < world_height; i++)
		for (int j = 0; j < world_width; j++)
			if (world[i][j] != prev_world[i][j])
				return -1;
	return 0;
}

//Получение координат соседей точки (ограниченное поле)
void read_point_neighbors(int coordinates_nb[][2], int x, int y, int world_height, int world_width)
{
	int k = 0;

	for (int i = x - 1; i <= x + 1; i++) {
		for (int j = y - 1; j <= y + 1; j++) {
			if (i == x && j == y)
				continue;
			coordinates_nb[k][0] = i;
			coordinates_nb[k][1] = j;
			k++;
		}
	}
}


//Количество живых соседей у клетки с координатами x, y (ограниченное поле)
int count_live_neighbors(int x, int y, int world_height, int world_width)
{
	int count = 0;
	int coordinates_nb[8][2];
	int _x, _y;

	read_point_neighbors(coordinates_nb, x, y, world_height, world_width);

	for (int i = 0; i < 8; i++) {
		_x = coordinates_nb[i][0];
		_y = coordinates_nb[i][1];

		if (_x < 0 || _y < 0)
			continue;

		if (_x >= world_width || _y >= world_height)
			continue;

		if (prev_world[_x][_y] == 1)
			count++;
	}

	return count;
}



//Генерировать следующее поколение игрового мира (ограниченное поле)
void next_generation(int world_height, int world_width)
{
	int live_nb;
	int p;

	for (int i = 0; i < world_height; i++) {
		for (int j = 0; j < world_width; j++) {
			p = prev_world[i][j];
			live_nb = count_live_neighbors(i, j, world_height, world_width);

			if (p == 0) {
				if (live_nb == 3)
					world[i][j] = 1;
			}
			else
				if (live_nb < 2 || live_nb > 3)
					world[i][j] = 0;
		}
	}
}