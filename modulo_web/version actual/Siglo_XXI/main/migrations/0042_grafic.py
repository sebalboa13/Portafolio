# Generated by Django 3.1.3 on 2021-12-04 18:05

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0041_proveedores'),
    ]

    operations = [
        migrations.CreateModel(
            name='grafic',
            fields=[
                ('id', models.AutoField(primary_key=True, serialize=False)),
                ('total', models.IntegerField()),
                ('date', models.DateField(auto_now_add=True)),
            ],
        ),
    ]