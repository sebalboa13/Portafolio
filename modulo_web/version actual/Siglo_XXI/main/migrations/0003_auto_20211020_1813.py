# Generated by Django 3.1.3 on 2021-10-20 21:13

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0002_auto_20211012_1858'),
    ]

    operations = [
        migrations.AlterField(
            model_name='productosxxi',
            name='nombre',
            field=models.CharField(max_length=50),
        ),
    ]
